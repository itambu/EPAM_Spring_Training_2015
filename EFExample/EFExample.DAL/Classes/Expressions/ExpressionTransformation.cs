using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EFExample.DAL.Classes.Expressions
{

    public class ExpressionTransformation<Source, Target> : ExpressionVisitor
    {
        //        ParameterExpression _parameter;

        //public CustomExpressionVisitor(ParameterExpression parameter)
        //{
        //    _parameter = parameter;
        //}

        //protected override Expression VisitParameter(ParameterExpression node)
        //{
        //    return _parameter;
        //}
        
        protected override Expression VisitMember(MemberExpression node)
        {
            if (node.Member.MemberType == System.Reflection.MemberTypes.Property)
            {
                if (node.Member.ReflectedType == typeof(Source))
                {

                }
                PropertyInfo sourceProperty = typeof(Source).GetProperty(node.Member.Name);
                
                MemberExpression memberExpression = null;
                var memberName = node.Member.Name;
                var otherMember = ;
                memberExpression = Expression.Property(Visit(node.Expression), otherMember);
                return memberExpression;
            }
            else
            {
                return base.VisitMember(node);
            }
        }
    }
}
