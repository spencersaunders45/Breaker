using Breaker.Game.Casting;


namespace Breaker.Game.Scripting 
{
    /// <summary>
    /// A callback that can be used to trigger scene changes.
    /// </summary>
    public interface ActionCallback
    {
        /// <summary>
        /// Called when we need to transition from one scene to the next.
        /// </summary>
        /// <param name="sceneName">The next scene.</param>
        void OnNext(string sceneName);
    }
}