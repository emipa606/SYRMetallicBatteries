# GitHub Copilot Instructions for `[SYR] Metallic Batteries (Continued)`

## Mod Overview and Purpose

The `[SYR] Metallic Batteries (Continued)` mod is an enhanced version of the original mod by Syrchalis. It introduces various types of batteries made from different metals, each offering unique benefits and drawbacks. This mod aims to provide players with diverse energy storage options, enhancing gameplay strategy and base management in RimWorld.

### Key Features and Systems

1. **Steel Battery**
   - An improved version of the vanilla battery, requiring more steel and offering a higher storage capacity.

2. **Silver Battery**
   - Offers improvements across all areas and is very cost-efficient. Requires silver in addition to base materials.

3. **Golden Battery**
   - Features high efficiency with normal capacity. Reduces overall energy production needs due to its high efficiency.

4. **Plasteel Battery**
   - Normal efficiency and high capacity. It's lightweight, won't short-circuit in rain, and is perfect for powering deep drills or caravans.

5. **Uranium Battery**
   - Offers high efficiency and very high capacity. However, it can short-circuit in rain, explodes violently when damaged, and produces a lot of heat. Temperature management is critical.

6. **Advanced Battery**
   - This constructable battery provides high efficiency and capacity, does not short-circuit in rain, and never breaks down.

7. **Vanometric Battery**
   - Not constructable and found similarly to the vanometric power cell. It has supreme stats and a high market value, making it desirable for traders and raiders.

The mod is compatible with savegames, allows safe addition and removal, and has no known incompatibilities.

## Coding Patterns and Conventions

- Follow C# coding standards and naming conventions.
- Ensure clarity and consistency in method and variable naming.
- Utilize comments to explain complex logical sections, especially in harmony patches.
- Structure XML files systematically with clear hierarchy and descriptive node names.

## XML Integration

- XML files manage the mod's configuration, definitions, and translations.
- Ensure XML specifications are correctly defined in `ResearchProjectDefs.xml` and others.
- Keep files organized, ensuring each XML file serves a distinct purpose linked to its definition or configuration.

## Harmony Patching

- Harmony is used to modify the game's runtime behavior without altering the original source code.
- **HarmonyPatches.cs** file is central to implementing these patches.
- Use prefix and postfix methods to safely intercept game logic, ensuring backward compatibility.
  
  **Example:**
  csharp
  [HarmonyPatch(typeof(TargetClass), "TargetMethod")]
  class HarmonyPatches
  {
      static void Prefix()
      {
          // Code to execute before the target method
      }

      static void Postfix()
      {
          // Code executed after the target method
      }
  }
  

## Suggestions for Copilot

- When writing new features or fixing bugs, utilize Copilot for suggestions on:
  - C# syntax and logic for RimWorld's specific APIs.
  - XML structure and common patterns used for RimWorld mod files.
  - Harmony patching techniques and examples.
  
- Request Copilot to provide:
  - Boilerplate code for new Harmony patches.
  - Best practices for energy management logic related to new battery types.
  - Snippets for integrating new features into existing game mechanics seamlessly.

- Use Copilot to speed up repetitive tasks like defining XML nodes or generating method stubs for Harmony patches.

By leveraging GitHub Copilot effectively in your development process, you can streamline coding tasks, ensure best practices, and maintain the mod's quality and compatibility with RimWorld updates.

## Project Solution Guidelines
- Relevant mod XML files are included as Solution Items under the solution folder named XML, these can be read and modified from within the solution.
- Use these in-solution XML files as the primary files for reference and modification.
- The `.github/copilot-instructions.md` file is included in the solution under the `.github` solution folder, so it should be read/modified from within the solution instead of using paths outside the solution. Update this file once only, as it and the parent-path solution reference point to the same file in this workspace.
- When making functional changes in this mod, ensure the documented features stay in sync with implementation; use the in-solution `.github` copy as the primary file.
- In the solution is also a project called Assembly-CSharp, containing a read-only version of the decompiled game source, for reference and debugging purposes.
- For any new documentation, update this copilot-instructions.md file rather than creating separate documentation files.


## Hard rules (must follow)
- Do NOT run commands that modify the repo (no git commit, git apply, dotnet format) unless explicitly asked.
- Prefer minimal reads: read only the smallest code region needed (around the suspicious lines).
- When mentioning SonarQube issues, automatically use the SonarQube MCP service to fetch and address issues instead of making inferred fixes without querying SonarQube first.
- When mentioning the rimworld log, automatically use the Rimworld MCP service to fetch the log.

