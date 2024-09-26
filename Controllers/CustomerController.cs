using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Threading.Tasks;
using Gymany_API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Text;
using System.Net;




namespace Gymany_API.Controllers
{
   [ApiController]
   [Route("api/[controller]")]
   public class CustomerController : ControllerBase
   {
      private readonly ApplicationDbContext _db;
      public CustomerController(ApplicationDbContext db)
      {
         this._db = db;
      }
      [HttpGet]
      public IActionResult GetCustomer()
      {
         IEnumerable<Customer> list = this._db.Customers.ToList();
         return Ok(list);
      }
      [HttpGet("id", Name = "GetCustomerByID")]
      public IActionResult GetCustomerByID(int id)
      {
         var obj = this._db.Customers.Find(id);
         if (obj == null)
         {
            return NotFound();
         }
         return Ok(obj);
      }
      [HttpPost]
      public IActionResult Create(Customer obj)
      {
         if (obj == null)
         {
            return BadRequest("...");
         }
         this._db.Customers.Add(obj);
         this._db.SaveChanges();
         return CreatedAtRoute("GetCustomerByID", new { id = obj.cus_id, obj });
      }

      [HttpPut("Id")]
      public IActionResult Edit(int id, Customer obj)
      {
         if (obj == null)
         {
            return BadRequest("...");
         }
         Customer cus = this._db.Customers.AsNoTracking().FirstOrDefault(c => c.cus_id == id);//loi khi bi entities theo doi
         this._db.Customers.Update(obj);
         this._db.SaveChanges();
         return CreatedAtRoute("GetCustomerByID", new { id = obj.cus_id, obj });
      }

      [HttpDelete("Id")]
      public IActionResult Delete(int id)
      {
         Customer obj = this._db.Customers.Find(id);
         if (obj == null)
         {
            return NotFound();
         }
         this._db.Customers.Remove(obj);
         this._db.SaveChanges();
         return CreatedAtRoute("GetCustomerByID", new { id = obj.cus_id, obj });
      }

      [HttpGet("email", Name = "GetCustomerByEmail")]
      public IActionResult GetCustomerByEmail(string email)
      {
         var obj = this._db.Customers.FirstOrDefault(c => c.cus_email == email);
         if (obj == null)
         {
            return NotFound();
         }
         return Ok(obj);
      }

      [HttpPost("forgotpassword")]
      public IActionResult ForgotPassword(string email)
      {
         var customer = _db.Customers.FirstOrDefault(c => c.cus_email == email);
         if (customer == null)
         {
            return NotFound("Không tìm thấy khách hàng với địa chỉ email này.");
         }

         var newPassword = GenerateRandomPassword();
         customer.cus_password = EncryptPassword(newPassword); // Encrypt the new password before saving
         _db.SaveChanges();

         SendPasswordEmail(email, customer.cus_password);

         return Ok("Một email chứa mật khẩu mới đã được gửi đến địa chỉ email của bạn.");
      }

      private string GenerateRandomPassword()
      {
         // Độ dài của mật khẩu mong muốn
         int length = 10;

         // Tập ký tự cho phép trong mật khẩu
         string validChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";

         // Sử dụng StringBuilder để hiệu quả hơn khi làm việc với chuỗi
         StringBuilder sb = new StringBuilder();

         // Sử dụng Random để tạo mật khẩu ngẫu nhiên
         Random random = new Random();

         // Tạo mật khẩu bằng cách chọn ngẫu nhiên các ký tự từ tập hợp validChars
         for (int i = 0; i < length; i++)
         {
            // Chọn một ký tự ngẫu nhiên từ validChars
            int index = random.Next(validChars.Length);

            // Thêm ký tự được chọn vào StringBuilder
            sb.Append(validChars[index]);
         }

         // Trả về mật khẩu đã được tạo ra
         return sb.ToString();
      }

      private string EncryptPassword(string password)
      {
         // Encrypt the password logic (You can use any encryption algorithm like MD5, SHA256, etc.)
         using (var sha256 = SHA256.Create())
         {
            var hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
            return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
         }
      }
      private void SendPasswordEmail(string email, string newPassword)
      {
         // Gửi email chứa mật khẩu mới
         MailMessage mail = new MailMessage("Ducsieuda@gmail.com", email);
         SmtpClient client = new SmtpClient();
         client.Port = 587;
         client.Host = "smtp.gmail.com";
         client.EnableSsl = true; // hoặc client.UseSsl = true;
         client.Credentials = new System.Net.NetworkCredential("Ducsieuda@gmail.com", "tjgj tslh nbyk xmjk"); // Thay thế YourPassword bằng mật khẩu của bạn
         mail.Subject = "New Password";
         mail.Body = "Your new password is: " + newPassword;
         client.Send(mail);
      }


      [HttpPost("checklogin")]
      public IActionResult CheckLogin(string username, string password)
      {
         var obj = this._db.Customers.AsNoTracking().FirstOrDefault(c => c.cus_username.Equals(username) && c.cus_password.Equals(password));
         if (obj == null)
         {
            return NotFound();
         }
         return Ok(obj);
      }
      [HttpGet("username", Name = "CheckUsername")]
      public IActionResult CheckUsername(string username)
      {
         var obj = this._db.Customers.AsNoTracking().FirstOrDefault(c => c.cus_username.Equals(username));
         if (obj == null)
         {
            return NotFound();
         }
         return Ok(obj);
      }
   }
}