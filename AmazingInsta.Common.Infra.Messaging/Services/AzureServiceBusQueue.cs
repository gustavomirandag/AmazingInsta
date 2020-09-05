﻿using AmazingInsta.Common.Application.CQRS.Messaging;
using AmazingInsta.Common.Infra.Messaging.Properties;
using Microsoft.Azure.ServiceBus;
using Newtonsoft.Json;
using System;
using System.Text;
using System.Threading.Tasks;

namespace AmazingInsta.Common.Infra.Messaging.Services
{
    public class AzureServiceBusQueue : IMediatorHandler
    {
        private readonly string _connectionString;

        public AzureServiceBusQueue()
        {
            _connectionString = Resources.ServiceBusConnectionString;
        }

        public async Task<bool> EnqueueAsync<T>(T command, string queueName)
        {
            var message = JsonConvert.SerializeObject(command);
            await SendMessageAsync(message, queueName);
            return true;
        }

        private async Task SendMessageAsync(string message, string queueName)
        {
            var queueClient = new QueueClient(_connectionString, queueName);
            var encodedMessage = new Message(Encoding.UTF8.GetBytes(message));
            await queueClient.SendAsync(encodedMessage);
            await queueClient.CloseAsync();
        }
    }
}
