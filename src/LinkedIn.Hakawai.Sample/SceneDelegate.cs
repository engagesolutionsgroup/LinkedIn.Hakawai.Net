namespace LinkedIn.Hakawai.Sample;

[Register("SceneDelegate")]
public class SceneDelegate : UIResponder, IUIWindowSceneDelegate
{
    [Export("window")] public UIWindow? Window { get; set; }

    [Export("scene:willConnectToSession:options:")]
    public void WillConnect(UIScene scene, UISceneSession session, UISceneConnectionOptions connectionOptions)
    {
        // Use this method to optionally configure and attach the UIWindow `window` to the provided UIWindowScene `scene`.
        // If using a storyboard, the `window` property will automatically be initialized and attached to the scene.
        // This delegate does not imply the connecting scene or session are new (see UIApplicationDelegate `GetConfiguration` instead).
    }

    [Export("sceneDidDisconnect:")]
    public void DidDisconnect(UIScene scene)
    {
        // Called as the scene is being released by the system.
        // This occurs shortly after the scene enters the background, or when its session is discarded.
        // Release any resources associated with this scene that can be re-created the next time the scene connects.
        // The scene may re-connect later, as its session was not neccessarily discarded (see UIApplicationDelegate `DidDiscardSceneSessions` instead).
    }

    [Export("sceneDidBecomeActive:")]
    public void DidBecomeActive(UIScene scene)
    {
        // Called when the scene has moved from an inactive state to an active state.
        // Use this method to restart any tasks that were paused (or not yet started) when the scene was inactive.
    }

    [Export("sceneWillResignActive:")]
    public void WillResignActive(UIScene scene)
    {
        // Called when the scene will move from an active state to an inactive state.
        // This may occur due to temporary interruptions (ex. an incoming phone call).
    }

    [Export("sceneWillEnterForeground:")]
    public void WillEnterForeground(UIScene scene)
    {
        // Called as the scene transitions from the background to the foreground.
        // Use this method to undo the changes made on entering the background.
    }

    [Export("sceneDidEnterBackground:")]
    public void DidEnterBackground(UIScene scene)
    {
        // Called as the scene transitions from the foreground to the background.
        // Use this method to save data, release shared resources, and store enough scene-specific state information
        // to restore the scene back to its current state.
    }
}

public static class Helpers
{
    public static List<MentionEntity> MentionEntities =
    [
        new MentionEntity("Alan Perlis", "1"),
        new MentionEntity("Maurice Wilkes", "2"),
        new MentionEntity("Richard Hamming", "3"),
        new MentionEntity("Marvin Minsky", "4"),
        new MentionEntity("James Wilkinson", "5"),
        new MentionEntity("John McCarthy", "6"), // DupeTesting: First instance
        new MentionEntity("Edsger Dijkstra", "7"),
        new MentionEntity("Charles Bachman", "8"),
        new MentionEntity("Donald Knuth", "9"),
        new MentionEntity("Allen Newell", "10"),
        new MentionEntity("Herbert Simon", "11"),
        new MentionEntity("Michael Rabin", "12"),
        new MentionEntity("Dana Scott", "13"),
        new MentionEntity("John Backus", "14"),
        new MentionEntity("Robert Floyd", "15"),
        new MentionEntity("Kenneth Iverson", "16"),
        new MentionEntity("Antony Hoare", "17"),
        new MentionEntity("Edgar Codd", "18"),
        new MentionEntity("Stephen Cook", "19"),
        new MentionEntity("Dennis Ritchie", "20"),
        new MentionEntity("Kenneth Thompson", "21"),
        new MentionEntity("Niklaus Wirth", "22"),
        new MentionEntity("Richard Karp", "23"),
        new MentionEntity("John Hopcroft", "24"),
        new MentionEntity("Robert Tarjan", "25"),
        new MentionEntity("John McCarthy", "6"), // DupeTesting: Second instance. New Page.
        new MentionEntity("John McCarthy", "6"), // DupeTesting: Third instance. Same Page.
        // Entity that has an autocorrect-able first name
        new MentionEntity("Asd Tarjan", "26"),
        new MentionEntity("Asd Tarjan2 👍", "27"),
        new MentionEntity("TEST @", "28"),
        // korean
        new MentionEntity("긴 기 ㅣ", "29"),
        // "asdf" on persian keyboard
        new MentionEntity("شسیب شسیب شسی شسیب شس", "30"),
        new MentionEntity("😀😀 😁😁", "31"),
        // japanese
        new MentionEntity("らい", "32"),
        new MentionEntity("Asd Tarjan2 👍👍", "33"),
        new MentionEntity("😀FirstName1😀 😁LastName2😁", "34"),
        new MentionEntity("🦋FirstName1🦋 🐛LastName2🐛", "35")
    ];
}