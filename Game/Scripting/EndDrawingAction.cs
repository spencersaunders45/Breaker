using Raylib_cs;
using Breaker.Game.Casting;
using Breaker.Game.Services;


namespace Breaker.Game.Scripting
{
    public class EndDrawingAction : Action
    {
        private VideoService videoService;
        
        public EndDrawingAction(VideoService videoService)
        {
            this.videoService = videoService;
        }

        public void Execute(Cast cast, Script script, ActionCallback callback)
        {
            videoService.FlushBuffer();
        }
    }
}