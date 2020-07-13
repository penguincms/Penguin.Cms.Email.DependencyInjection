using Penguin.Cms.Email.Services;
using Penguin.Cms.Email.Templating.Repositories;
using Penguin.DependencyInjection.Abstractions.Enums;
using Penguin.DependencyInjection.Abstractions.Interfaces;
using Penguin.Email.Abstractions.Interfaces;
using Penguin.Email.Templating;
using Penguin.Email.Templating.Abstractions.Interfaces;

namespace Penguin.Cms.Email.DependencyInjection
{
    public class RegisterMailProviders : IRegisterDependencies
    {
        public void RegisterDependencies(IServiceRegister serviceRegister)
        {
            if (serviceRegister is null)
            {
                throw new System.ArgumentNullException(nameof(serviceRegister));
            }

            serviceRegister.Register(typeof(ISendTemplates), typeof(EmailTemplateRepository), ServiceLifetime.Scoped);
            serviceRegister.Register(typeof(IQueueAndSendMail), typeof(EmailService), ServiceLifetime.Scoped);
            serviceRegister.Register(typeof(IQueueAndSendMail), typeof(EmailService), ServiceLifetime.Scoped);
            serviceRegister.Register(typeof(ISendMail), typeof(EmailService), ServiceLifetime.Scoped);
            serviceRegister.Register(typeof(EmailRenderer), typeof(EmailRenderer), ServiceLifetime.Scoped);
        }
    }
}