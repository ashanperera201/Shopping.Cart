#region References
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
#endregion

#region Namespace
namespace Cart.Contracts.Repositories
{
    public interface IGenericDataRepository<TModel, TDTO>
      where TModel : class
      where TDTO : class
    {
        #region Crud operation methods without 'Async'
        /// <summary>
        /// Inserts the specified dto.
        /// </summary>
        /// <param name="dto">The dto.</param>
        void Insert(TDTO dto);
        /// <summary>
        /// Inserts the specified dto.
        /// </summary>
        /// <param name="dto">The dto.</param>
        /// <param name="returnId">if set to <c>true</c> [return identifier].</param>
        /// <param name="returnName">Name of the return.</param>
        /// <returns></returns>
        int Insert(TDTO dto, bool returnId, string returnName);
        /// <summary>
        /// Inserts the model.
        /// </summary>
        /// <param name="dto">The dto.</param>
        /// <returns></returns>
        TDTO InsertModel(TDTO dto);
        /// <summary>
        /// Updates the specified dto.
        /// </summary>
        /// <param name="dto">The dto.</param>
        void Update(TDTO dto);
        /// <summary>
        /// Updates the model.
        /// </summary>
        /// <param name="dto">The dto.</param>
        /// <returns></returns>
        TDTO UpdateModel(TDTO dto);
        /// <summary>
        /// Deletes the specified expression.
        /// </summary>
        /// <param name="expression">The expression.</param>
        void Delete(Expression<Func<TModel, bool>> expression);
        /// <summary>
        /// Gets all.
        /// </summary>
        /// <returns></returns>
        List<TDTO> GetAll();
        /// <summary>
        /// Finds the by.
        /// </summary>
        /// <param name="expression">The expression.</param>
        /// <param name="mapReset">if set to <c>true</c> [map reset].</param>
        /// <returns></returns>
        List<TDTO> FindBy(Expression<Func<TModel, bool>> expression, bool mapReset = true);
        /// <summary>
        /// Singles the or default.
        /// </summary>
        /// <param name="expression">The expression.</param>
        /// <returns></returns>
        TDTO SingleOrDefault(Expression<Func<TModel, bool>> expression);
        /// <summary>
        /// Anies the specified expression.
        /// </summary>
        /// <param name="expression">The expression.</param>
        /// <returns></returns>
        bool Any(Expression<Func<TModel, bool>> expression);
        /// <summary>
        /// Saves this instance.
        /// </summary>
        void Save();
        #endregion

        #region Crud operation methods with 'Async'
        /// <summary>
        /// Saves the model asynchronous.
        /// </summary>
        /// <param name="dto">The dto.</param>
        /// <returns></returns>
        Task<TDTO> InsertModelAsync(TDTO dto);
        /// <summary>
        /// Updates the model asynchronous.
        /// </summary>
        /// <param name="dto">The dto.</param>
        /// <returns></returns>
        Task<TDTO> UpdateModelAsync(TDTO dto);
        /// <summary>
        /// Gets all asynchronous.
        /// </summary>
        /// <returns></returns>
        Task<List<TDTO>> GetAllAsync();
        /// <summary>
        /// Deletes the asynchronous.
        /// </summary>
        /// <param name="expression">The expression.</param>
        /// <returns></returns>
        Task<int> DeleteAsync(Expression<Func<TModel, bool>> expression);
        /// <summary>
        /// Saves the asynchronous.
        /// </summary>
        /// <returns></returns>
        Task<int> SaveAsync();
        #endregion
    }
}
#endregion
