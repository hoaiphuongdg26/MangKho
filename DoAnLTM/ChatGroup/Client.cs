using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatGroup
{
    public partial class Client : Form
    {
        //các biến dùng để kết nối mạng và quản lý các luồng đọc/ghi message
        private TcpClient client;
        private NetworkStream stream;
        private Thread receiveThread;
        private bool isConnectedToServer = false;
        private string userName;
        private string attachmentFilePath = null;
        private ConcurrentDictionary<string, byte[]> files = new ConcurrentDictionary<string, byte[]>();
        private bool isLogin;
        private bool allIsDisposed;

        public Client()
        {
            InitializeComponent();
        }
        private void ReceiveMessages()
        {
            if (!isConnectedToServer)
            {
                // Đưa ra thông báo không tìm thấy máy chủ trên RichTextBox
                AppendMessage("SERVER NOT FOUND");
                return;
            }
            //lặp với điều kiện có kết nối tới Server rồi
            while (client.Connected)
            {
                string receivedData = ReadMessage(stream);
                //string fileName = Path.GetFileName(attachmentFilePath);
                if (receivedData != null &&  receivedData.Contains("[FILE]"))
                {
                    AppendMessage(receivedData);
                    string[] arr_message = receivedData.Split($"[FILE] - ");
                    int colonIndex = arr_message[1].IndexOf(":");
                    string fileName = arr_message[1].Substring(0, colonIndex);
                    string fileContents = arr_message[1].Substring(colonIndex + 1);

                    AppendAttach(fileName, fileContents);
                }
                else if (receivedData != null)
                {
                    AppendMessage(receivedData);
                }
                else
                {
                    AppendMessage("Server disconnected.");
                    break;
                }
            }
        }
        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tb_Name.Text))
            {
                try
                {
                    //Tạo kết nối tới server
                    client = new TcpClient("127.0.0.1", 8080);
                    //dùng để ghi và đọc dữ liệu từ kết nối
                    stream = client.GetStream();
                    //Tạo luồng
                    //Sử dụng ReceiveMessage để có thể đọc message được gửi từ server và hiển thị
                    receiveThread = new Thread(ReceiveMessages);
                    //Thực thi luồng
                    receiveThread.Start();
                    // Thiết lập trạng thái kết nối
                    isConnectedToServer = true;
                    // lấy tên người dùng ra và gửi tới Server
                    userName = tb_Name.Text;
                    tb_Name.Font = new Font(tb_Name.Font, FontStyle.Bold);
                    // Gửi tên người dùng tới server
                    SendMessage($"{userName}");

                    // Vô hiệu hóa nút "Join" và cho phép gửi tin sau khi kết nối thành công
                    btn_Login.Enabled = false;
                    btn_Logout.Enabled = true;
                    //btn_Send.Enabled = true;
                    tb_Message.Enabled = true;
                    btn_Attach.Enabled = true;
                    tb_Name.ReadOnly = true;
                }
                catch (Exception ex)
                {
                    AppendMessage("[ERROR] " + ex.Message);
                    // Đưa ra thông báo không tìm thấy máy chủ trên RichTextBox
                    AppendMessage("SERVER NOT FOUND");
                    isConnectedToServer = false;
                }
            }
            else
            {
                MessageBox.Show("Please enter a username.");
            }
            isLogin = true;
        }
        private void btn_Send_Click(object sender, EventArgs e)
        {
            userName = tb_Name.Text;
            tb_Name.Font = new Font(tb_Name.Font, FontStyle.Bold);

            string message = tb_Message.Text;
            if (tb_Message.Text != "" && tb_Message.Enabled)
            {
                SendMessage($"{userName}: {message}");
            }
            if (!string.IsNullOrEmpty(attachmentFilePath))
            {
                SendFile(attachmentFilePath);
            }
            //Xoá sau khi gửi
            tb_Message.Clear();
            lb_showFileName.Text = "";
            attachmentFilePath = null;
        }

        private void SendMessage(string message)
        {
            if (client != null && client.Connected)
            {
                byte[] buffer = Encoding.UTF8.GetBytes(message);
                stream.Write(buffer, 0, buffer.Length);
                stream.Flush();
                //stream = null;
            }
        }
        /* private string ReadMessage(NetworkStream stream)
         {
             if (!stream.CanRead || !client.Connected)
             {
                 return null;
             }
             byte[] buffer = new byte[1024];
             int bytesRead = stream.Read(buffer, 0, buffer.Length);
             if (bytesRead > 0)
             {
                 return Encoding.UTF8.GetString(buffer, 0, bytesRead);
             }
             else
             {
                 return null;
             }
         }*/
        private string ReadMessage(NetworkStream stream)
        {
            if (!stream.CanRead || !client.Connected)
            {
                return null;
            }

            byte[] buffer = new byte[1024];
            int bytesRead = 0;
            try
            {
                bytesRead = stream.Read(buffer, 0, buffer.Length);
            }
            catch (IOException)
            {
                // Xử lý ngoại lệ IOException khi kết nối bị đóng
                return null;
            }

            if (bytesRead > 0)
            {
                return Encoding.UTF8.GetString(buffer, 0, bytesRead);
            }
            else
            {
                return null;
            }
        }

        private void AppendMessage(string message)
        {
            if (!allIsDisposed)
            {
                //check coi đúng luồng không, nếu ở luồng khác, sử dụng Invoke để gọi lại AppendMessage trên luồng chính
                if (rtb_Client.InvokeRequired)
                {
                    rtb_Client.Invoke(new Action<string>(AppendMessage), message);
                }
                else
                {
                    string[] messageParts = message.Split(':');
                    if (messageParts.Length == 2)
                    {
                        Font boldFont = new Font(rtb_Client.Font, FontStyle.Bold);
                        rtb_Client.SelectionFont = boldFont;
                        rtb_Client.AppendText(messageParts[0]);

                        Font ItalicFont = new Font(rtb_Client.Font, FontStyle.Italic);
                        rtb_Client.SelectionFont = ItalicFont;
                        rtb_Client.AppendText($": ({DateTime.Now})");

                        rtb_Client.SelectionFont = rtb_Client.Font; // Đặt lại font gốc
                        rtb_Client.AppendText(": " + messageParts[1] + "\n");
                    }
                    else
                    {
                        rtb_Client.AppendText(message + "\n");
                    }
                }
            }
        }
        private void AppendAttach(string fileName, string fileContens)
        {
            if (ls_Files.InvokeRequired)
            {
                // Gọi lại phương thức AppendAttach trên luồng chính bằng cách sử dụng Invoke
                Invoke(new Action<string, string>(AppendAttach), fileName, fileContens);
            }
            else
            {
                // Thêm mục vào ListBox
                ls_Files.Items.Add(fileName);
                byte[] fileContents_byte = Encoding.UTF8.GetBytes(fileContens);

                files[fileName] = fileContents_byte;
            }
        }
        private void Client_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isLogin)
            {
                MessageBox.Show("Vui lòng đăng xuất trước khi đóng form!");
                e.Cancel = true;
            }
            else
            {
                if (client != null && client.Connected)
                {
                    client.Close();
                }
                if (stream != null)
                {
                    stream.Close();
                }
            }
            allIsDisposed = true;
        }

        private void btn_Attach_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                attachmentFilePath = openFileDialog.FileName;
                lb_showFileName.Text = Path.GetFileName(attachmentFilePath);
            }
        }
        private void SendFile(string filePath)
        {
            try
            {
                if (client != null && client.Connected)
                {
                    //Tạo luồng đọc file
                    using (FileStream fileStream = File.OpenRead(filePath))
                    {
                        // Lấy tên file từ đường dẫn
                        string fileName = Path.GetFileName(filePath);
                        // Gửi tên file tới server
                        SendMessage($"[FILE] - {fileName}:");

                        // Đọc và gửi dữ liệu tệp tin 
                        byte[] buffer = new byte[1024];
                        int bytesRead;
                        while ((bytesRead = fileStream.Read(buffer, 0, buffer.Length)) > 0)
                        {
                            stream.Write(buffer, 0, bytesRead);
                        }
                    }
                }
                else
                {
                    AppendMessage("Not connected to server.");
                }
            }
            catch (Exception ex)
            {
                AppendMessage(ex.Message);
            }
        }

        private void btn_Download_Click(object sender, EventArgs e)
        {
            string selectedFileName = ls_Files.SelectedItem.ToString();
            if (files.ContainsKey(selectedFileName))
            {
                string fileContent = Encoding.UTF8.GetString(files[selectedFileName]);

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.FileName = selectedFileName;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string saveFilePath = saveFileDialog.FileName;
                    if (!saveFilePath.ToLower().EndsWith(".txt"))
                    {
                        saveFilePath += ".txt";
                    }
                    File.WriteAllText(saveFilePath, fileContent);
                    MessageBox.Show("File downloaded successfully!");
                }
            }
            else
            {
                MessageBox.Show("Selected file not found in the file list.");
            }
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {  
            isLogin = false;
            Task.Run(() =>
            {
                SendMessage($"{tb_Name.Text} is disconected");
                this.Invoke((Action)(() =>
                {
                    tb_Name.Enabled = true;
                    tb_Name.ReadOnly = false;
                    tb_Name.Clear();
                    tb_Message.Enabled = false;
                    btn_Attach.Enabled = false;
                    btn_Send.Enabled = false;
                    btn_Login.Enabled = true;
                    btn_Logout.Enabled = false;

                }));
                if (stream != null && stream.CanRead)
                {
                    ReadMessage(stream);
                }
                if (client != null && client.Connected)
                {
                    client.Close();
                }
                if (stream != null)
                {
                    stream.Close();
                }
            });
        }

        private void tb_Message_TextChanged(object sender, EventArgs e)
        {
            btn_Send.Enabled = !string.IsNullOrEmpty(tb_Name.Text);
        }
    }
}
