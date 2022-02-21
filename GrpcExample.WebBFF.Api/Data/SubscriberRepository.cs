using System;
using System.Collections.Generic;
using System.Linq;
using Dapper;
using GrpcExample.WebBFF.Api.Model;
using Microsoft.Data.SqlClient;

namespace GrpcExample.WebBFF.Api.Data
{
    public class SubscriberRepository
    {
        private SqlConnection _connection => new SqlConnection("Server=.;DataBase=ProxySubscribers;Trusted_Connection=True");
        
        public SubscriberRepository()
        {
            
        }

        public void InsertSubscriber(Subscriber subscriber)
        {
            using (var connection = _connection)
            {
                var dynamicParam = new DynamicParameters();
                dynamicParam.Add("ClientId",subscriber.ClientId);
                dynamicParam.Add("ClientName",subscriber.ClientName);
                dynamicParam.Add("ClientServerAdress",subscriber.ClientServerAdress);
                dynamicParam.Add("CallbackEndpoint",subscriber.CallbackEndpoint);
                dynamicParam.Add("SubscribedTime",DateTime.Now);

                string query = @"INSERT INTO [dbo].[ProxySubscribers]
                                   ([ClientId]
                                   ,[ClientName]
                                   ,[ClientServerAdress]
                                   ,[CallbackEndpoint]
                                   ,[SubscribedTime])
                             VALUES
                                   (@ClientId
                                   ,@ClientName
                                   ,@ClientServerAdress
                                   ,@CallbackEndpoint
                                   ,@SubscribedTime)";
                
                connection.Execute(query,dynamicParam);
            }
        }

        public List<Subscriber> GetSubscriberList()
        {
            using (var connection = _connection)
            {
                var query = @"SELECT [Id]
                            ,[ClientId]
                            ,[ClientName]
                            ,[ClientServerAdress]
                            ,[CallbackEndpoint]
                            ,[SubscribedTime]
                            FROM [GrpcDB].[dbo].[ProxySubscribers]";
                
                return connection.Query<Subscriber>(query).ToList();
            }
        }
    }
}