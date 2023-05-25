using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace Core.DataAccess //Core katmanı diğer katmanları referans almaz
{
    //Generic yapı için oluşturulur, Sınırlamak için generic constraint denir
    //class: Referans tip
    //Generic kısımda T yi sınırlandırdık. T bir class olabilir, IEntity ile imlemente edilmiş olabilir, Ayrıca new'lenebilir olacak. Bu sayede abstrackt class olmaz
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null); // GetAll(p => p.CategoryId==2) gibi filtreleme yapmamıza izin verir
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}