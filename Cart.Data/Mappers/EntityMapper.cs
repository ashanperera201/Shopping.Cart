#region References
using AutoMapper;
using Cart.Contracts.Common;
using Cart.Data.CartModels;
using Cart.Entities.DataTransferObjects;
#endregion

#region Namespace
namespace Cart.Data.Mappers
{
    public class EntityMapper : IEntityMapper
    {
        /// <summary>
        /// The configuration
        /// </summary>
        private MapperConfiguration _config;

        /// <summary>
        /// The mapper
        /// </summary>
        private IMapper _mapper;

        /// <summary>
        /// Initializes a new instance of the <see cref="EntityMapper"/> class.
        /// </summary>
        public EntityMapper()
        {
            Configure();
            Create();
        }

        /// <summary>
        /// Maps the specified source.
        /// </summary>
        /// <typeparam name="TSource">The type of the source.</typeparam>
        /// <typeparam name="TDestination">The type of the destination.</typeparam>
        /// <param name="source">The source.</param>
        /// <returns></returns>
        public TDestination Map<TSource, TDestination>(TSource source)
        {
            return _mapper.Map<TSource, TDestination>(source);
        }

        /// <summary>
        /// Configures this instance.
        /// </summary>
        private void Configure()
        {
            _config = new MapperConfiguration(_cfg =>
            {
                #region Order
                _cfg.CreateMap<Orders, OrderDTO>()
                .ForMember(d => d.OrderId, m => m.MapFrom(o => o.Id))
                .ForMember(d => d.OrderItem, m => m.MapFrom(o => o.OrderItem))
                .ReverseMap();

                _cfg.CreateMap<OrderItem, OrderItemDTO>().ReverseMap();

                #endregion

                #region Product
                _cfg.CreateMap<Products, ProductDTO>().ReverseMap();
                #endregion
            });
        }

        /// <summary>
        /// Creates this instance.
        /// </summary>
        private void Create()
        {
            _mapper = _config.CreateMapper();
        }
    }
}
#endregion