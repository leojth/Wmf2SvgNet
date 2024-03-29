/*
 * Copyright 2007-2008 Hidekatsu Izuno
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, 
 * either express or implied. See the License for the specific language
 * governing permissions and limitations under the License.
 */
namespace Wmf2SvgNet.Gdi
{
    public interface IGdiFont : IGdiObject
    {
        short Height { get; }

        short Width { get; }

        short Escapement { get; }

        short Orientation { get; }

        short Weight { get; }

        bool IsItalic { get; }

        bool IsUnderlined { get; }

        bool IsStrikedOut { get; }

        byte Charset { get; }

        byte OutPrecision { get; }

        byte ClipPrecision { get; }

        byte Quality { get; }

        byte PitchAndFamily { get; }

        string FaceName { get; }
    }
}