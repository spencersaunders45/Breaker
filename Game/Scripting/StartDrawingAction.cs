using Breaker.Game.Casting;
using Breaker.Game.Services;


namespace Breaker.Game.Scripting
{
    public class StartDrawingAction : Action
    {
        private VideoService videoService;
        
        public StartDrawingAction(VideoService videoService)
        {
            this.videoService = videoService;
        }

        public void Execute(Cast cast, Script script, ActionCallback callback)
        {
            videoService.ClearBuffer();
        }
    }
}