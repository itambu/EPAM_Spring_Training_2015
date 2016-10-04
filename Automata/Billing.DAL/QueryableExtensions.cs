using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Linq.Expressions;

namespace Billing.DAL
{
    public static class QueryableExtensions
    {
        public static Type[] GetEntityTypes(object container)
        {
            return container.GetType().GetProperties()
                .Where(x => x.PropertyType.IsGenericType && x.PropertyType.GetGenericTypeDefinition() == typeof(System.Data.Entity.DbSet<>))
                .Select(x => x.PropertyType.GetGenericArguments().FirstOrDefault()).ToArray();
        }
        
        //public static IQueryable<TEntity> IncludeReferences<TEntity>(this IQueryable<TEntity> source, bool recurrsive = false)
        //{
        //    return source.IncludeReferences(typeof(TEntity), null, GetEntityTypes(source.Expression.
        //}

        //public static IQueryable<TargetInterface> Query<EntityInterface,TargetInterface>(
        //     this IQueryable<EntityInterface> source,
        //   Expression<Func<EntityInterface, TargetInterface>> expression)
        //{
        //    return source.Select<EntityInterface, TargetInterface>(expression);
        //}

        public static IQueryable<TEntity> IncludeReferences<TEntity>(this IQueryable<TEntity> source, Type currentType, string parentPropertyName, Type[] entityTypesForInclude, bool recurrsive = false)
        {
            var propertiesToInclude = currentType
                .GetProperties(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance).Join(
                    entityTypesForInclude,
                    y => y.PropertyType,
                    x => x,
                    (propInfo, entityType) => propInfo);

            foreach (var p in propertiesToInclude)
            {
                string propertyName = String.Concat( parentPropertyName , parentPropertyName!=null? ".": null, p.Name);
                source = source.Include(propertyName);
                if (recurrsive)
                {
                    source = IncludeReferences<TEntity>( source, p.PropertyType, propertyName, entityTypesForInclude, recurrsive );
                }
            }
            return source;
        }
    }
}
