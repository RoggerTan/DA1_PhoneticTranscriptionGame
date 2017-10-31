using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using echo_main.BS_layer.DBEntities;

namespace echo_main.BS_layer.DBFunc
{
    class BSTimeRunning : IDbFunction<int, timerunning_record>, IDisposable
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

        public BSTimeRunning(QuizlibdbEntities db = null)
        {
            Db = db;
        }

        public Task Create(timerunning_record obj)
        {
            Db.timerunning_record.AddOrUpdate(obj);
            return Db.SaveChangesAsync();
        }

        /// <summary>
        /// Read the best timerunning record
        /// </summary>
        /// <param name="userId">User Id</param>
        /// <returns></returns>
        public Task<timerunning_record> Read(int userId)
            => Task.Run(async () =>
            {
                var foundRecord = Db.timerunning_record.Where(x => x.user_id == userId);
                if (!foundRecord.Any()) return null;
                {
                    var best = await foundRecord.MaxAsync(x => x.word_count);
                    return foundRecord.FirstOrDefault(x => x.word_count == best);
                }
            });

        public Task Update(int id, timerunning_record obj)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            _db?.Dispose();
        }
    }
}
