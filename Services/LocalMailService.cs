using Cityinfo;
using System.Diagnostics;
using Infocity.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infocity.Services
{
    public class LocalMailService : IMailService
    {
        private string _mailTo = Startup.Configuration["mailSettings:mailToAddress"];
        private string _mailFrom = Startup.Configuration["mailSettings:mailFromAddress"];

        public void Send(string subject, string message)
        {
            //Send mail - output to debug window
            Debug.WriteLine($"Mail from {_mailFrom} to {_mailTo}, with LocalMailService");
            Debug.WriteLine($"Subject : {subject}");
            Debug.WriteLine($"Massage : {message}");
        }
    }
}
