using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Billing.ModelInterfaces.ExpressionTransformationSupport
{
    public static class ParameterTypeTransformer<TSourceDelegate, TTargetDelegate>
    {
        public static Expression<TTargetDelegate> Transform<TSourceType, TTargetType>(Expression<TSourceDelegate> sourceExpression, ParameterExpression sourceParameter)
        {
            ParameterExpression targetParameter = Expression.Parameter(typeof(TTargetType), sourceParameter.Name);
            Expression newBody = new TransformVisitor<TTargetType>(sourceParameter, targetParameter).Visit(sourceExpression.Body);
            var paramsList = sourceExpression.Parameters.ToList();
            var position = paramsList.IndexOf(sourceParameter);
            paramsList[position] = targetParameter;
            return Expression.Lambda<TTargetDelegate>(newBody, paramsList);
        }

        private class TransformVisitor<TTarget> : ExpressionVisitor
        {
            private ParameterExpression _targetParameter;
            private ParameterExpression _sourceParameter;

            public TransformVisitor(ParameterExpression sourceParameter, ParameterExpression targetParameter)
            {
                _sourceParameter = sourceParameter;
                _targetParameter = targetParameter;
            }

            protected override Expression VisitParameter(ParameterExpression node)
            {
                return node == _sourceParameter ? _targetParameter : base.VisitParameter(node);
            }

            protected override Expression VisitMember(MemberExpression node)
            {
                if ((node.Member.MemberType & (System.Reflection.MemberTypes.Property | System.Reflection.MemberTypes.Field)) != 0)
                {
                    MemberExpression newExpression = Expression.Property(Visit(node.Expression), node.Member.Name);
                    return newExpression;
                }
                else
                {
                    return base.VisitMember(node);
                }
            }
        }
    }
}
