# Discord Video Trimmer
A cross-platform tool for trimming and compressing clips, designed for use with Discord due to its restrictive file size limits of 10MB, though this isn't necessarily limited to use with Discord.

Gameplay clips, such as those recorded with Nvidia's ShadowPlay can often exceed 300MB for a 1 minute recording, making them difficult to share among friends.  Reducing the size of clips also results in smaller file sizes, meaning less disk space is used for storing clips, and less bandwidth is used when sharing clips.

This application currently supports the following platforms:
 - Windows
 - macOS

This application is a replacement for my original [VideoTrimmer tool](https://github.com/HarryCMather/VideoTrimmer), as it contained legacy Windows Media Player media elements in a WinForms project.  The usage of this legacy Windows Media Player element meant the application could only support .NET Framework (and therefore, no newer language features), and was limited to Windows-only environments.  This replacement tool is written in .NET MAUI with MVVM, and is designed to be cross-platform.

# How To Run
## Prerequisites
## Running the tool

# Usage
## Available Settings
## Guides

# Planned Changes
 - Update Readme.
 - Refactor logic from old solution.
 - Add unit tests.
 - Add CI/CD using GitHub Actions and Releases.
 - Add "Check for Updates" functionality.
