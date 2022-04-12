# NOTE: SPOOKBOT IS NOW ON A FULL RE-CODE FOR V2, IT'S NOT USING THIS CODE NOW. IT'S ONLY A NADEKO FORK ANYWAYS.

# Spookbot v1 Source Code


- This repository is only here for archival purposes.

- The public instance of Spookbot is not using this code. The new version is closed-source (until we releases v3) - you can't host it yourself right now.


# Self-Hosting
I recommended you to follow the [Nadeko Bot Guidelines](https://nadekobot.readthedocs.io/en/v4/) and use their instance for the newest updated features.
Nadeko was currently in v4, while Spookbot uses Nadeko v2.35 Fork.

<h2>If you REALLY want to self host Spookbot, here are the steps.</h2>
Note: Spookbot was hosted on Linux. It will not work on Windows or other OS.<br>
<strong>I will not provide any support on self-hosting it, you are on <i>your</i> own when any problems are occurred.</strong>
<br><br>

1. Install NadekoBot's prerequisites.
   - Execute `cd ~ && wget -N https://gitlab.com/Kwoth/nadeko-bash-installer/-/raw/v4/linuxAIO.sh && bash linuxAIO.sh`
   - type `1` and press `enter`
   - Exit.
2. Head to `src/NadekoBot`
3. Open `credentials.json` and fill in your Bot Token and Your User ID in the `Token` and `OwnerIds` Field.
4. Fill in the other details if you want to unlock advanced features.
5. Starting the bot
   - cd into the folder: `cd src/NadekoBot`
   - do `sudo dotnet run -c release`

