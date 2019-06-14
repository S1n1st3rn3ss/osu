// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Game.Tournament.Screens.Teams;

namespace osu.Game.Tournament.Tests
{
    public class TestSceneTeamsEditorScreen : LadderTestScene
    {
        public TestSceneTeamsEditorScreen()
        {
            Add(new TeamsEditorScreen());
        }
    }
}
