using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using echo_main.BS_layer.DBEntities;

namespace echo_main.BS_layer.DBFunc
{
    class BSParrot : IDbFunction<int, parrot_word>, IDisposable
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

        public BSParrot(QuizlibdbEntities db = null)
        {
            Db = db;
        }

        public Task Create(parrot_word obj)
        {
            throw new NotImplementedException();
        }

        public Task<parrot_word> Read(int id)
        {
            throw new NotImplementedException();
        }

        public Task<(int Keyword, int[] Words)> ReadWords(int userid)
            => Task.Run(async () =>
            {
                int levelId;
                var parrotLevel = (await Db.users.FirstOrDefaultAsync(x => x.id == userid)).parrot_level;
                if (parrotLevel == null)
                {
                    levelId = 1;
                    parrotLevel = await Db.parrot_level.FirstOrDefaultAsync(x => x.id == levelId);
                }
                else
                {
                    levelId = parrotLevel.id;
                }
                return (parrotLevel.key_word, await Db.parrot_word.Where(x => x.parrot_id == levelId)
                    .Select(x => x.word_id).ToArrayAsync());
            });

        public Task Update(int userid, parrot_word obj)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int userid)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            _db?.Dispose();
        }

    }
}
