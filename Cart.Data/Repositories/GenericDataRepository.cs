#region References
using AutoMapper;
using Cart.Contracts.Repositories;
using Cart.Data.CartModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
#endregion

#region Namespace
namespace Cart.Data.Repositories
{
    public class GenericDataRepository<TModel, TDTO> : IGenericDataRepository<TModel, TDTO>
        where TModel : class
        where TDTO : class
    {
        private readonly ShoppingContext _shoppingContext;
        private bool disposed = false;

        /// <summary>
        /// Initializes a new instance of the <see cref="GenericDataRepository{TModel, TDTO}"/> class.
        /// </summary>
        /// <param name="eBEntities">The e b entities.</param>
        public GenericDataRepository(ShoppingContext shoppingContext)
        {
            _shoppingContext = shoppingContext;
        }

        /// <summary>
        /// Anies the specified expression.
        /// </summary>
        /// <param name="expression">The expression.</param>
        /// <returns></returns>
        public bool Any(Expression<Func<TModel, bool>> expression)
        {
            var result = _shoppingContext.Set<TModel>().Any(expression);
            return result;
        }

        /// <summary>
        /// Deletes the specified expression.
        /// </summary>
        /// <param name="expression">The expression.</param>
        public void Delete(Expression<Func<TModel, bool>> expression)
        {
            _shoppingContext.Set<TModel>().RemoveRange(_shoppingContext.Set<TModel>().Where(expression));
            Save();
        }

        /// <summary>
        /// Deletes the asynchronous.
        /// </summary>
        /// <param name="expression">The expression.</param>
        /// <returns></returns>
        public virtual async Task<int> DeleteAsync(Expression<Func<TModel, bool>> expression)
        {
            _shoppingContext.Set<TModel>().RemoveRange(_shoppingContext.Set<TModel>().Where(expression));
            return await SaveAsync();
        }

        /// <summary>
        /// Finds the by.
        /// </summary>
        /// <param name="expression">The expression.</param>
        /// <param name="mapReset">if set to <c>true</c> [map reset].</param>
        /// <returns></returns>
        public List<TDTO> FindBy(Expression<Func<TModel, bool>> expression, bool mapReset = true)
        {
            var entity = _shoppingContext.Set<TModel>();
            var query = entity.Where(expression).ToList();

            if (mapReset)
            {
                Mapper.Reset();
            }
            return MapToDtoList<TModel, TDTO>(query).ToList();
        }

        /// <summary>
        /// Gets all.
        /// </summary>
        /// <returns></returns>
        public List<TDTO> GetAll()
        {
            var query = _shoppingContext.Set<TModel>().ToList();
            return MapToDtoList<TModel, TDTO>(query).ToList();
        }

        /// <summary>
        /// Gets all asynchronous.
        /// </summary>
        /// <returns></returns>
        public async Task<List<TDTO>> GetAllAsync()
        {
            var query = await _shoppingContext.Set<TModel>().ToListAsync();
            return MapToDtoList<TModel, TDTO>(query).ToList();
        }

        /// <summary>
        /// Inserts the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        public void Insert(TDTO entity)
        {
            var item = MapDtoToEntity<TModel, TDTO>(entity);
            _shoppingContext.Set<TModel>().Add(item);
            Save();
        }

        /// <summary>
        /// Inserts the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <param name="returnId">if set to <c>true</c> [return identifier].</param>
        /// <param name="returnName">Name of the return.</param>
        /// <returns></returns>
        public int Insert(TDTO entity, bool returnId, string returnName)
        {
            var item = MapDtoToEntity<TModel, TDTO>(entity);
            _shoppingContext.Set<TModel>().Add(item);
            Save();
            return returnId ? (int)item.GetType().GetProperty(returnName).GetValue(item, null) : 0;
        }

        /// <summary>
        /// Inserts the model.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <returns></returns>
        public TDTO InsertModel(TDTO entity)
        {
            var item = MapDtoToEntity<TModel, TDTO>(entity);
            _shoppingContext.Set<TModel>().Add(item);
            Save();
            return MapEntityToDto<TModel, TDTO>(item);
        }

        /// <summary>
        /// Saves this instance.
        /// </summary>
        public void Save()
        {
            _shoppingContext.SaveChanges();
        }

        /// <summary>
        /// Saves the asynchronous.
        /// </summary>
        /// <returns></returns>
        public async Task<int> SaveAsync()
        {
            return await _shoppingContext.SaveChangesAsync();
        }

        /// <summary>
        /// Inserts the model asynchronous.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <returns></returns>
        public async Task<TDTO> InsertModelAsync(TDTO entity)
        {
            var item = MapDtoToEntity<TModel, TDTO>(entity);
            _shoppingContext.Set<TModel>().Add(item);
            await SaveAsync();
            return MapEntityToDto<TModel, TDTO>(item);
        }

        /// <summary>
        /// Singles the or default.
        /// </summary>
        /// <param name="predicate">The predicate.</param>
        /// <returns></returns>
        public TDTO SingleOrDefault(Expression<Func<TModel, bool>> predicate)
        {
            var ent = _shoppingContext.Set<TModel>();
            var query = ent.AsNoTracking().SingleOrDefault(predicate);

            if (query == null)
                return null;

            Mapper.Reset();
            return MapEntityToDto<TModel, TDTO>(query);
        }

        /// <summary>
        /// Updates the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        public void Update(TDTO entity)
        {
            var participationDto = MapEntityToDto<TDTO, TModel>(entity);
            _shoppingContext.Set<TModel>().Attach(participationDto);
            _shoppingContext.Entry(participationDto).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            Save();
        }

        /// <summary>
        /// Updates the model.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <returns></returns>
        public virtual TDTO UpdateModel(TDTO entity)
        {
            var participationDto = MapEntityToDto<TDTO, TModel>(entity);
            _shoppingContext.Set<TModel>().Attach(participationDto);
            _shoppingContext.Entry(participationDto).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            Save();
            return MapEntityToDto<TModel, TDTO>(participationDto);
        }

        /// <summary>
        /// Updates the model asynchronous.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <returns></returns>
        public async Task<TDTO> UpdateModelAsync(TDTO entity)
        {
            var participationDto = MapEntityToDto<TDTO, TModel>(entity);
            _shoppingContext.Set<TModel>().Attach(participationDto);
            _shoppingContext.Entry(participationDto).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            await SaveAsync();
            return MapEntityToDto<TModel, TDTO>(participationDto);
        }

        /// <summary>
        /// Maps to dto list.
        /// </summary>
        /// <typeparam name="TEntity">The type of the entity.</typeparam>
        /// <typeparam name="TDTO">The type of the dto.</typeparam>
        /// <param name="entity">The entity.</param>
        /// <returns></returns>
        public virtual IEnumerable<TDTO> MapToDtoList<TEntity, TDTO>(IEnumerable<TEntity> entity)
           where TEntity : class
           where TDTO : class
        {

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<TEntity, TDTO>();
            });

            IMapper mapper = config.CreateMapper();
            return mapper.Map<IEnumerable<TEntity>, IEnumerable<TDTO>>(entity);
        }


        /// <summary>
        /// Maps the dto to entity.
        /// </summary>
        /// <typeparam name="TEntity">The type of the entity.</typeparam>
        /// <typeparam name="TDto">The type of the dto.</typeparam>
        /// <param name="dto">The dto.</param>
        /// <returns></returns>
        public virtual TEntity MapDtoToEntity<TEntity, TDto>(TDto dto)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<TDto, TEntity>().ReverseMap();
            });

            IMapper mapper = config.CreateMapper();
            return mapper.Map<TDto, TEntity>(dto);
        }

        /// <summary>
        /// Maps the entity to dto.
        /// </summary>
        /// <typeparam name="TEntity">The type of the entity.</typeparam>
        /// <typeparam name="TDto">The type of the dto.</typeparam>
        /// <param name="entity">The entity.</param>
        /// <returns></returns>
        public virtual TDto MapEntityToDto<TEntity, TDto>(TEntity entity)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<TEntity, TDto>();
            });

            IMapper mapper = config.CreateMapper();
            return mapper.Map<TEntity, TDto>(entity);
        }
    }
}
#endregion