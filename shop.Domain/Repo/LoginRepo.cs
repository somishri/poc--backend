using eshop.Models.Models;
using Microsoft.IdentityModel.Tokens;
using shop.Domain.Repo.Interface;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Web.ModelBinding;

namespace shop.Domain.Repo
{
    public class LoginRepo:ILoginRepo
    {
        public  IEnumerable<string> LoginUser(Customers customer)
        {
            using (var context = new shopEntities())
            {
                var customerLogin = context.Customers.Where(x => x.EmailAddress == customer.EmailAddress && x.Password == customer.Password).FirstOrDefault();
                if (customerLogin == null)
                {
                    return null;
                }
                var tokenDescriptor = new SecurityTokenDescriptor
                {
                    Subject = new ClaimsIdentity(new Claim[]
                {
                        new Claim("CusId",customerLogin.CusId.ToString()),

                        new Claim(ClaimTypes.Role,customerLogin.Role)
                }),
                    Expires = DateTime.UtcNow.AddMinutes(120),
                    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(Encoding.UTF8.GetBytes("1234567890123456")), SecurityAlgorithms.HmacSha256Signature)
                };

                var tokenHandler = new JwtSecurityTokenHandler();
                var securityToken = tokenHandler.CreateToken(tokenDescriptor);
                var token = tokenHandler.WriteToken(securityToken);
                return new string[] { token, customerLogin.FirstName, customerLogin.Role, customerLogin.CusId.ToString() };
            }
        }
    }
}
