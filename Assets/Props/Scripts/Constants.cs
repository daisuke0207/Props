namespace Props
{
    /// <summary>
    /// 定数を管理する
    /// </summary>
    public static class Constants
    {
        public static class Player
        {
            /// <summary>プレイヤーオブジェクトのタグ</summary>
            public const string Tag = "Player";
        }

        public static class Camera
        {
            public const int LowPriority = 5;
            public const int DefaultPriority = 10;      
            public const int PlayerSelectPriority = 25;
            public const int SystemAutoPriority = 50;
            public const int DangerPriority = 100;
        }
    }
}