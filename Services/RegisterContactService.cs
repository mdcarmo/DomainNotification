using Core;
using Domain.Commands;
using Domain.Entities;
using Domain.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class RegisterContactService : ServerCommand
    {
        private RegisterContactCommand _command;
        //criar o repositorio


        //injetar o repositorio
        public RegisterContactService(RegisterContactCommand command)
            : base(command)
        {
            _command = command;
        }


        public void Run()
        {
            Validate();
            if (HasNotifications())
                return;

            var contact = new Contact(_command.FirstName, _command.LastName, _command.Email);
            
            //salva o contato no repositorio
        }

        public void Validate()
        {
            AddNotification(Assert.Lenght(_command.FirstName, 5, 20, "FirstName", ValidationErrors.FirstNameIsInvalid));
            //criar todas as validações possiveis.
            AddNotification(new DomainNotification("FistName","Nome já cadastrado no repositório"));
        }
    }
}
