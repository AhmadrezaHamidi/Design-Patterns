namespace  CompositeSpecificationFirstAdvanced.Structer;

public interface ISpecification<T>
{
    public bool IsSatisfiedBy(T entity);
}

public abstract class CompositeSpecification<T> : ISpecification<T>
{
    public CompositeSpecification<T> And(ISpecification<T> right)
        =>  new AndSpecofocation<T>(this, right); 

    public CompositeSpecification<T> or(ISpecification<T> right)
         =>  new OrSpecofocation<T>(this, right); 
    
    public CompositeSpecification<T> Not() => new NotSpecofocation<T>(this); 
    public abstract bool IsSatisfiedBy(T entity);
}




public class EvenNumber : CompositeSpecification<int>
{
    public override bool IsSatisfiedBy(int entity) => entity % 2 == 0;
}

public class PositiveNumber : CompositeSpecification<int>
{
    public override bool IsSatisfiedBy(int entity) => entity % 2 == 0;

}


public class AndSpecofocation<T> : CompositeSpecification<T>
{
    private readonly ISpecification<T> _leftChild;
    private readonly ISpecification<T> _rightChild;

    public AndSpecofocation(ISpecification<T> leftChild, ISpecification<T> rightChild)
    {
        _leftChild = leftChild;
        _rightChild = rightChild;
    }
    
    public override bool IsSatisfiedBy(T entity) => _leftChild.IsSatisfiedBy(entity) && _rightChild.IsSatisfiedBy(entity);
}

public class OrSpecofocation<T> : CompositeSpecification<T>
{
    private readonly ISpecification<T> _leftChild;
    private readonly ISpecification<T> _rightChild;
    
    public OrSpecofocation(ISpecification<T> leftChild, ISpecification<T> rightChild)
    {
        _leftChild = leftChild;
        _rightChild = rightChild;
    }
    public override bool IsSatisfiedBy(T entity) => _leftChild.IsSatisfiedBy(entity) || _rightChild.IsSatisfiedBy(entity);
}

public class  NotSpecofocation<T> : CompositeSpecification<T>
{
        private readonly ISpecification<T> _leftChild;
    
        public NotSpecofocation(ISpecification<T> leftChild)
        {
            _leftChild = leftChild;
        }
    
    // public bool IsSatisfiedBy(T entity) => _leftChild.IsSatisfiedBy(entity);
    public override bool IsSatisfiedBy(T entity) =>_leftChild.IsSatisfiedBy(entity);
}

public class OPerationStrcuter<T> : CompositeSpecification<T>
{
    private readonly ISpecification<T> _leftChild;
    private readonly ISpecification<T> _rightChild;

    public OPerationStrcuter(ISpecification<T> leftChild, ISpecification<T> rightChild)
    {
        _leftChild = leftChild;
        _rightChild = rightChild;
    }

    public override bool IsSatisfiedBy(T entity) => _leftChild.IsSatisfiedBy(entity) || _rightChild.IsSatisfiedBy(entity);

}







