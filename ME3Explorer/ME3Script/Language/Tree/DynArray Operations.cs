﻿using ME3Script.Analysis.Symbols;
using ME3Script.Analysis.Visitors;
using ME3Script.Utilities;

namespace ME3Script.Language.Tree
{
    public abstract class DynArrayOperation : Expression
    {
        public Expression DynArrayExpression;

        protected DynArrayOperation(Expression dynArrayExpression, SourcePosition start = null, SourcePosition end = null) : base(ASTNodeType.CompositeReference, start, end)
        {
            DynArrayExpression = dynArrayExpression;
        }

        public override VariableType ResolveType()
        {
            return null;
        }
    }
    public class DynArrayLength : DynArrayOperation
    {
        public DynArrayLength(Expression dynArrayExpression, SourcePosition start = null, SourcePosition end = null) : base(dynArrayExpression, start, end){}

        public override VariableType ResolveType()
        {
            return SymbolTable.IntType;
        }

        public override bool AcceptVisitor(IASTVisitor visitor)
        {
            return visitor.VisitNode(this);
        }
    }
    public class DynArrayAdd : DynArrayOperation
    {
        public Expression CountArg;

        public DynArrayAdd(Expression dynArrayExpression, Expression countArg, SourcePosition start = null, SourcePosition end = null) : base(dynArrayExpression, start, end)
        {
            CountArg = countArg;
        }

        public override bool AcceptVisitor(IASTVisitor visitor)
        {
            return visitor.VisitNode(this);
        }
    }
    public class DynArrayAddItem : DynArrayOperation
    {
        public Expression ValueArg;

        public DynArrayAddItem(Expression dynArrayExpression, Expression valueArg, SourcePosition start = null, SourcePosition end = null) : base(dynArrayExpression, start, end)
        {
            ValueArg = valueArg;
        }

        public override bool AcceptVisitor(IASTVisitor visitor)
        {
            return visitor.VisitNode(this);
        }
    }
    public class DynArrayInsert : DynArrayOperation
    {
        public Expression IndexArg;
        public Expression CountArg;

        public DynArrayInsert(Expression dynArrayExpression, Expression indexArg, Expression countArg, SourcePosition start = null, SourcePosition end = null) : base(dynArrayExpression, start, end)
        {
            IndexArg = indexArg;
            CountArg = countArg;
        }

        public override bool AcceptVisitor(IASTVisitor visitor)
        {
            return visitor.VisitNode(this);
        }
    }
    public class DynArrayInsertItem : DynArrayOperation
    {
        public Expression IndexArg;
        public Expression ValueArg;

        public DynArrayInsertItem(Expression dynArrayExpression, Expression indexArg, Expression valueArg, SourcePosition start = null, SourcePosition end = null) : base(dynArrayExpression, start, end)
        {
            IndexArg = indexArg;
            ValueArg = valueArg;
        }

        public override bool AcceptVisitor(IASTVisitor visitor)
        {
            return visitor.VisitNode(this);
        }
    }
    public class DynArrayRemove : DynArrayOperation
    {
        public Expression IndexArg;
        public Expression CountArg;

        public DynArrayRemove(Expression dynArrayExpression, Expression indexArg, Expression countArg, SourcePosition start = null, SourcePosition end = null) : base(dynArrayExpression, start, end)
        {
            IndexArg = indexArg;
            CountArg = countArg;
        }

        public override bool AcceptVisitor(IASTVisitor visitor)
        {
            return visitor.VisitNode(this);
        }
    }
    public class DynArrayRemoveItem : DynArrayOperation
    {
        public Expression ValueArg;

        public DynArrayRemoveItem(Expression dynArrayExpression, Expression valueArg, SourcePosition start = null, SourcePosition end = null) : base(dynArrayExpression, start, end)
        {
            ValueArg = valueArg;
        }

        public override bool AcceptVisitor(IASTVisitor visitor)
        {
            return visitor.VisitNode(this);
        }
    }
    public class DynArrayFind : DynArrayOperation
    {
        public Expression ValueArg;

        public DynArrayFind(Expression dynArrayExpression, Expression valueArg, SourcePosition start = null, SourcePosition end = null) : base(dynArrayExpression, start, end)
        {
            ValueArg = valueArg;
        }

        public override VariableType ResolveType()
        {
            return SymbolTable.IntType;
        }

        public override bool AcceptVisitor(IASTVisitor visitor)
        {
            return visitor.VisitNode(this);
        }
    }
    public class DynArrayFindStructMember : DynArrayOperation
    {
        public Expression MemberNameArg;
        public Expression ValueArg;

        public DynArrayFindStructMember(Expression dynArrayExpression, Expression memberNameArg, Expression valueArg, SourcePosition start = null, SourcePosition end = null) : base(dynArrayExpression, start, end)
        {
            MemberNameArg = memberNameArg;
            ValueArg = valueArg;
        }

        public override VariableType ResolveType()
        {
            return SymbolTable.IntType;
        }

        public override bool AcceptVisitor(IASTVisitor visitor)
        {
            return visitor.VisitNode(this);
        }
    }
    public class DynArraySort : DynArrayOperation
    {
        public Expression CompareFuncArg;

        public DynArraySort(Expression dynArrayExpression, Expression comparefunctionArg, SourcePosition start = null, SourcePosition end = null) : base(dynArrayExpression, start, end)
        {
            CompareFuncArg = comparefunctionArg;
        }

        public override bool AcceptVisitor(IASTVisitor visitor)
        {
            return visitor.VisitNode(this);
        }
    }
}