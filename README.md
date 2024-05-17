# PlayValve-TA-Test Demo Overview

### Note
This is a demo designed to showcase game flow, with implemented features serving to illustrate key concepts.

### Home Screen Design

The home screen includes ambient animations to enhance depth and liveliness. This is achieved through animated river streaks and plant sprites. A custom sprite noise distortion shader has been created to impart natural motion to these elements efficiently, without high computational cost. This procedural animation technique eliminates the need for manual animation of each element.

Additionally, passing clouds are simulated using a particle system that periodically spawns 1-2 clouds, adding variety to the visual experience.

### Animation Style

Animations are designed to be punchy and playful, complementing the casual game theme. A light and creamy color palette was chosen to match the game's UI and aesthetic.

### Screen Logic

Screen logic is centralized in a screen object, with each screen deriving from it to simplify the code structure. Logic is modularized into different scripts, managed by a centralized game manager. Key components include:

- **Screen (Parent Script):** Manages animation functionality for all screens, with the following child scripts:
  - Home Screen Controller
  - Transition Controller
  - Game Screen Controller
- **Tile Manager:** Tracks game tiles and detects when a tile is selected.
- **Tile:** Contains animation data for the tiles.
- **Game Manager:** Controls the overall flow of the game experience.

### Optimization

For optimization, textures are compressed using Unity's built-in compressor. Similar textures are grouped into atlases to improve draw calls.

This structured approach ensures efficient resource use and a seamless gaming experience.
