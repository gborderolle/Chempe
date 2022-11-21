using System;
using System.Collections.Generic;
using System.Security.Claims;
using Domain.Chempe;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Services.DTOs;

namespace Services.Chempe
{
    public class Service_Session
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public Service_Session(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public void Create_session(string person_email, string jwt)
        {
            User_Session session = new(person_email);
            string jsonSession = JsonConvert.SerializeObject(session);
            string sessionEncrypted = BCrypt.Net.BCrypt.HashPassword(jsonSession);
            CookieOptions cookieOptions = new();
            cookieOptions.Expires = DateTimeOffset.Now.AddHours(2);
            _httpContextAccessor.HttpContext.Response.Cookies.Append("session", sessionEncrypted, cookieOptions);
        }

        public async void Authenticate_user_client(Person person)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Email, person.Email),
                new Claim(ClaimTypes.Name, person.Full_name),
                //new Claim(ClaimTypes.Role, user_client.Rol.Rol_Name),
            };

            // Gonza
            CookieOptions cookieOptions = new();
            cookieOptions.Expires = DateTimeOffset.Now.AddHours(2);
            _httpContextAccessor.HttpContext.Response.Cookies.Append("SessionUser", person.Email, cookieOptions);
            // Gonza


            var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
            //await _httpContextAccessor.HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity));
        }
    }
}