using System;

// README.md를 읽고 코드를 작성하세요.

class Program
{
    static void Main()
    {
        //1
        Notify notify = SayHello;
        notify += SayGoodbye;

        notify();

        static void SayHello()
        {
            Console.WriteLine("안녕하세요!");
        }

        static void SayGoodbye()
        {
            Console.WriteLine("안녕히 가세요!");
        }


        //2
        Button button = new Button();

        button.Click += HandleClick;
        button.Click += HandleClickAgain;

        button.OnClick();

        //3
        Player player = new Player();
        HealthBar healthBar = new HealthBar();
        SoundManager soundManager = new SoundManager();

        player.DamageTaken += healthBar.OnPlayerDamaged;
        player.DamageTaken += soundManager.OnPlayerDamaged;

        player.TakeDamage(30);

        //4
        Timer timer = new Timer();
        Logger logger = new Logger();

        timer.Tick += logger.OnTick;

        Console.WriteLine("=== 구독 상태 ===");
        timer.Start();

        timer.Tick -= logger.OnTick;

        Console.WriteLine("\n=== 구독 해제 후 ===");
        timer.Start();

        //5
        Sensor sensor = new Sensor();

        sensor.Alert += message =>
        {
            Console.WriteLine($"[경보] {message}");
        };

        sensor.Alert += message =>
        {
            Console.WriteLine($"[로그] {DateTime.Now}: {message}");
        };

        sensor.Detect("움직임 감지됨");
        sensor.Detect("온도 상승");

        //6
        GameCharacter hero = new GameCharacter("용사");

        hero.OnDeath += () => Console.WriteLine("캐릭터가 사망했습니다");

        hero.OnDamaged += health => Console.WriteLine($"남은 체력: {health}");

        hero.OnAttack += (damage, target) =>
            Console.WriteLine($"{target}에게 {damage} 데미지!");

        hero.Attack(50, "슬라임");
        hero.TakeDamage(30);
        hero.TakeDamage(80);

        //7
        Stock msStock = new Stock("MSFT", 100.00m);

        msStock.PriceChanged += (sender, e) =>
        {
            Stock stock = (Stock)sender;
            Console.WriteLine($"[{stock}]");
            Console.WriteLine($"  이전 가격: {e.OldPrice:C}");
            Console.WriteLine($"  현재 가격: {e.NewPrice:C}");
            Console.WriteLine($"  변동률: {e.ChangePercent:F2}%");
            Console.WriteLine();
        };

        msStock.Price = 110.00m;
        msStock.Price = 105.50m;
        msStock.Price = 120.00m;

        //8
        Car car = new Car(50);
        Dashboard dashboard = new Dashboard();

        dashboard.Subscribe(car);

        for (int i = 0; i < 7; i++)
        {
            car.Drive();
            Console.WriteLine();
        }

        dashboard.Unsubscribe(car);

        //9
        SecurePublisher publisher = new SecurePublisher();

        publisher.MyEvent += Handler1;
        publisher.MyEvent += Handler2;

        Console.WriteLine("\n이벤트 발생:");
        publisher.RaiseEvent();

        Console.WriteLine();
        publisher.MyEvent -= Handler1;

        Console.WriteLine("\n이벤트 발생:");
        publisher.RaiseEvent();

        //10
        Module1 m1 = new Module1();
        Module2 m2 = new Module2();

        GlobalNotifier.SendMessage("시스템 시작");
        Console.WriteLine();
        GlobalNotifier.SendMessage("데이터 로드 완료");
    }

    //2
    static void HandleClick()
    {
        Console.WriteLine("버튼이 클릭되었습니다!");
    }

    static void HandleClickAgain()
    {
        Console.WriteLine("클릭 처리 완료");
    }

    //9
    static void Handler1(object sender, EventArgs e)
    {
        Console.WriteLine("Handler1 실행됨");
    }

    static void Handler2(object sender, EventArgs e)
    {
        Console.WriteLine("Handler2 실행됨");
    }
}

//1
delegate void Notify();

//2
delegate void EventHandler2();