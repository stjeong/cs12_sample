GetData();

static MyType GetData()
{
    int n = 5;
    var t = new MyType(ref n);
    return t; // 컴파일 오류 - error CS8352: Cannot use variable 't' in this context because it may expose referenced variables outside of their declaration scope
}

// 외부 어셈블리에서 정의했을 지도 모를 MyType의 생성자 구현이 어떻게 되어 있는지 알 수 없으므로!
// 1. 만약 이렇게 구현되었다면 문제가 없지만,
ref struct MyType
{
    ref int n;
    public MyType(scoped ref int n1) { }
}

