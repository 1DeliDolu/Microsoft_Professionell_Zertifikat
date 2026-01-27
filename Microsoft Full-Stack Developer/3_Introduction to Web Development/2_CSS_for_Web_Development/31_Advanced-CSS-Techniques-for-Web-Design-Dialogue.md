# You Try It! Advanced Git Techniques - Answer Key

### **Step 1: Create and Manage Branches**

cd `<your-repository>`
git checkout -b feature-new-feature

# Make changes to a file

git add .
git commit -m "Add new feature"

**Step 2: Merge Branches and Resolve Conflicts**

# Switch to the main branch

git checkout main

# Edit a file, stage, and commit changes

git add .
git commit -m "Edit file in main branch"

# Switch to the feature branch

git checkout feature-new-feature

# Make changes, stage, and commit

git add .
git commit -m "Edit file in feature branch"

# Attempt to merge and resolve conflicts

git checkout main
git merge feature-new-feature

# Resolve conflicts in your editor

git add .
git commit -m "Resolve merge conflict"

**Step 3: Use Tags to Mark Important Commits**

git tag -a v1.0 -m "Initial release"
git push origin v1.0

**Step 4: Stash Changes Temporarily**

# Make changes but do not commit

git stash

# Switch branches

git checkout main

# View stashed changes

git stash list

# Apply stashed changes

git stash apply

**Step 5: Perform Interactive Rebase**

git rebase -i HEAD~4

# In the rebase editor:

# - Use pick to keep a commit

# - Use squash to combine commits

# - Use edit to modify a commit message

# Resolve conflicts if needed

git add .
git rebase --continue

# Force push changes after rebase

git push --force
