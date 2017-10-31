using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Threading.Tasks;
using echo_main.BS_layer.DBEntities;

namespace echo_main.BS_layer.DBFunc
{
    public class BsUser : IDbFunction<int, user>, IDisposable
    {
        private QuizlibdbEntities _db;

        private QuizlibdbEntities Db
        {
            get => _db;
            set
            {
                _db = value ?? new QuizlibdbEntities();
                _db.Database.CommandTimeout = 10;
            }
        }


        public BsUser(QuizlibdbEntities db = null)
        {
            Db = db;
        }

        public Task Create(user obj)
        {
            Db.users.Add(obj);
            return Task.Run(() => Db.SaveChanges() != 0);
        }

        public Task<user> Read(int id) => Db.users.AsNoTracking().FirstOrDefaultAsync(x => x.id == id);

        public Task<user> Read(string username, string password) => Db.users.AsNoTracking().FirstOrDefaultAsync(x => x.login_info.Any(y => y.username == username && y.password == password));

        public Task Update(int id, user obj)
        {
            var founduser = Db.users.FirstOrDefaultAsync().Result;
            founduser.avatar = obj.avatar;
            Db.users.AddOrUpdate(obj);
            return Db.SaveChangesAsync();
        }

        public Task Delete(int id)
        {
            return Task.Run(() =>
            {
                Db.users.Remove(Read(id).Result);
            });
        }

        public Task<int> GetCount() => Db.users.CountAsync();

        public Task<bool> CheckUsernameExists(string username) => Db.login_info.AnyAsync(x => x.username == username);

        public void Dispose()
        {
            Db?.Dispose();
        }
    }
}
