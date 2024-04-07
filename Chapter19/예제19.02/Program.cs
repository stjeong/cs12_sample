
/* ================= 19.2 제네릭 타입의 특성 적용 ================= */

DoCall();

[ExpectedResult<int>(10)]
static int DoCall()
{
    return int.MaxValue;
}

[AttributeUsage(AttributeTargets.Method)]
public class ExpectedResultAttribute<T> : Attribute
{
    T _expected;

    public ExpectedResultAttribute(T expected) => _expected = expected;
}