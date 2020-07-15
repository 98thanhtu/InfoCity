using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infocity.Services
{
    public interface IMailService
    {
        public void Send(string subject, string message);
    }
}
