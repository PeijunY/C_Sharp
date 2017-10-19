public static void Main(string[] args)
        {

                var emailAcount = "v-peiy@microsoft.com";
                string password = "*********";
                //Console.WriteLine("Please enter your microsoft mail password:");
                //Password = Console.ReadLine();
                //var reciver = "pajony@wicresoft.com";
                var content = "Don't forget to send a mail to FTE about stress test today!";      
                MailMessage message = new MailMessage();
                //设置发件人,发件人需要与设置的邮件发送服务器的邮箱一致
                MailAddress fromAddr = new MailAddress("v-peiy@microsoft.com");
                message.From = fromAddr;            //设置收件人,可添加多个,添加方法与下面的一样
                //message.To.Add(reciver);
                message.To.Add("v-peiy@microsoft.com");
                message.To.Add("v-saidai@microsoft.com");
                //设置抄送人
                //message.CC.Add("izhaofu@163.com");
                //设置邮件标题
                message.Subject = "Stress test weekly report";
                //设置邮件内容
                message.Body = content;
                //设置邮件发送服务器,服务器根据你使用的邮箱而不同,可以到相应的 邮箱管理后台查看,下面是QQ的
                SmtpClient client = new SmtpClient("smtphost", 587);
                //设置发送人的邮箱账号和密码
                //client.
                client.Credentials = new NetworkCredential(emailAcount, password);
                client.Send(message);
                Console.WriteLine("mail send successfully");
            }
