# Versioning
We use Git along with GitKraken to handle the projects versioning.

## Workflow
- Create a branch.
- Do your changes. 
- Make atomic commits until feature is finished.
- Merge main branch in your branch.
- Resolve eventual conflicts.
- Merge your branch in main
- Repeat 

## Rules
- Never commit / push anything on `main` branch.
- A branch should mirror a specific task. Ideally a kanban issue.
- Precede branch names with directories. eg. `feature/` `fix/` `doc/` `content/`
- Use **snake case** for branch naming. eg. `feature/a_very_long_branch_name`
