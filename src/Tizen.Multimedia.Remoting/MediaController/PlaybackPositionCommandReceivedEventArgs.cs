/*
 * Copyright (c) 2018 Samsung Electronics Co., Ltd All Rights Reserved
 *
 * Licensed under the Apache License, Version 2.0 (the License);
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an AS IS BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;

namespace Tizen.Multimedia.Remoting
{
    /// <summary>
    /// Provides data for the <see cref="MediaControlServer.PlaybackPositionCommandReceived"/> event.
    /// </summary>
    /// <since_tizen> 5 </since_tizen>
    public class PlaybackPositionCommandReceivedEventArgs : EventArgs
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PlaybackPositionCommandReceivedEventArgs"/> class.
        /// </summary>
        /// <param name="command">The playback position command.</param>
        /// <since_tizen> 5 </since_tizen>
        public PlaybackPositionCommandReceivedEventArgs(PlaybackPositionCommand command)
        {
            Command = command;
        }

        /// <summary>
        /// Gets the <see cref="PlaybackPositionCommand"/>.
        /// </summary>
        /// <since_tizen> 5 </since_tizen>
        public PlaybackPositionCommand Command { get; }
    }
}