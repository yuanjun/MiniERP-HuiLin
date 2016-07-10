using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Data;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.ComponentModel;
using System.Windows.Forms;

namespace ERPApplication
{
    class MailManager
    {
        private MailMessage mailMessage;
        private SmtpClient smtpClient;
        private String password;

        public MailManager()
        {
            mailMessage = new MailMessage();
            smtpClient = new SmtpClient();
        }

        /*
         * 设置邮件主题
         */
        public void setEmailTitle(String subject)
        {
            mailMessage.Subject = subject;
        }

        /*
         * 设置邮件发送人
         */
        public void setEmailFrom(String address)
        {
            mailMessage.From = new MailAddress(address);
        }

        public void setEmailFrom(String address, String displayName)
        {
            mailMessage.From = new MailAddress(address, displayName);
        }

        public void setEmailFrom(String address, String displayName, Encoding encoding)
        {
            mailMessage.From = new MailAddress(address, displayName, encoding);
        }

        /*
         * 设置邮件收件人
         */
        public void setEmailTo(String address)
        {
            mailMessage.To.Add(new MailAddress(address));
        }

        public void setEmailTo(String address, String displayName)
        {
            mailMessage.To.Add(new MailAddress(address, displayName));
        }

        public void setEmailTo(String address, String displayName, Encoding encoding)
        {
            mailMessage.To.Add(new MailAddress(address,displayName,encoding));
        }

        /*
         * 设置邮件正文
         */
        public void setEmailBody(String body)
        {
            mailMessage.Body = body;
        }

        /*
         * 设置邮件正文编码格式
         */
        public void setEmailEncoding()
        {
            mailMessage.BodyEncoding = Encoding.UTF8;
        }

        /*
         * 设置邮件发送级别
         */
        public void setEmailPriority()
        {
            mailMessage.Priority = MailPriority.Normal;
        }

        /*
         * 设置邮件发件人密码
         */
        public void setPassword(String password)
        {
            this.password = password;
        }

        /*
         * 设置邮件附件
         */
        public void setEmailAttachment(String path)
        {
            Attachment attachment = new Attachment(path);
            attachment.Name = Path.GetFileName(path);
            attachment.NameEncoding = Encoding.GetEncoding("gb2312");
            attachment.TransferEncoding = TransferEncoding.Base64;
            attachment.ContentDisposition.Inline = true;
            attachment.ContentDisposition.DispositionType = DispositionTypeNames.Inline;
            mailMessage.Attachments.Add(attachment);
        }

        /*
         * 非异步发送邮件
         */
        public void send()
        {
            if (mailMessage != null && smtpClient != null)
            {
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new NetworkCredential(mailMessage.From.Address, password);
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpClient.Host = "smtp." + mailMessage.From.Host;
                smtpClient.Port = 587;
                smtpClient.EnableSsl = true;
                try
                {
                    smtpClient.Send(mailMessage);
                }
                catch(Exception)
                {
                    MessageBox.Show("发送异常：请检查发送邮箱账户SMTP服务是否开启!");
                }
            }
        }

        /*
         * 异步发送邮件完毕回调函数
         */
        public static void SendCompletedCallback(object sender, AsyncCompletedEventArgs e)
        {
            Console.Write("邮件发送成功！");
        }

        /*
         * 异步发送邮件(问题：发送之后并未受到邮件，未使用)
         */
        public void sendAsync()
        {
            if (mailMessage != null && smtpClient != null)
            {
                //设置发件人身份票据
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new NetworkCredential(mailMessage.From.Address,password);
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpClient.Host = "smtp." + mailMessage.From.Host;
                smtpClient.Port = 587;
                smtpClient.EnableSsl = true;
                //注册异步发送邮件完成时的事件
                smtpClient.SendCompleted += new SendCompletedEventHandler(SendCompletedCallback);
                smtpClient.SendAsync(mailMessage, mailMessage.Body);
            }
        }
    }
}
