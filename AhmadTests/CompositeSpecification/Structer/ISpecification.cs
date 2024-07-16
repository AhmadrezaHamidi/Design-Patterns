namespace CompositeSpecification.Structer;

public interface ISpecification<T>
{
    public bool IsSatisfiedBy(T entity);
}


public class EvenNumber : ISpecification<int>
{
    public bool IsSatisfiedBy(int entity) => entity % 2 == 0;
}

public class PositiveNumber : ISpecification<int>
{
    public bool IsSatisfiedBy(int entity)
    {
        return entity > 0;
    }
}


public record AndSpecofocation<T>(ISpecification<T> leftChild, ISpecification<T> rightChild) : ISpecification<T>
{
    public bool IsSatisfiedBy(T entity) => leftChild.IsSatisfiedBy(entity) && rightChild.IsSatisfiedBy(entity);
}

public record OrSpecofocation<T>(ISpecification<T> leftChild, ISpecification<T> rightChild) : ISpecification<T>
{
    public bool IsSatisfiedBy(T entity) => leftChild.IsSatisfiedBy(entity) || rightChild.IsSatisfiedBy(entity);
}

public record NotSpecofocation<T>(ISpecification<T> child) : ISpecification<T>
{
    public bool IsSatisfiedBy(T entity) => child.IsSatisfiedBy(entity);
}


//
// private readonly ISpecification<T> _leftChild;
// private readonly ISpecification<T> _rightChild;
// public AndSpecofocation()
// {
//     _leftChild = leftChild;
//     _rightChild = rightChild;
// }




