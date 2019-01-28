using System;
using System.Collections.Generic;
using Lab21.Models;

namespace Lab21.DAL
{
    public class GCCSDbInitializer : System.Data.Entity.CreateDatabaseIfNotExists<GCCSContext>
    {
        protected override void Seed(GCCSContext context)
        {
            var users = new List<User>
            {
                new User{FirstName="Default",LastName="User",Username="DefaultUser"}
            };

            users.ForEach(s => context.Users.Add(s));
            context.SaveChanges();

            var sessions = new List<Session>
            {
                new Session{SessionID=0000}
            };

            sessions.ForEach(s => context.Sessions.Add(s));

            var logins = new List<Login>
            {
                new Login{LoginID=1}
            };

            logins.ForEach(s => context.Logins.Add(s));
            context.SaveChanges();
        }
    }
}