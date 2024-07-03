git --version
git config --global user.name "name"
git config user.name
git config --global user.email "hello@example.com"
git config user.email

mkdir repo
cd repo
ls -a repo
code repo
git init

git tag Release1 Release0
git push origin Release1 :Release0

git status
git diff
git add code.txt
git log --oneline
git commit -m "add code.txt"
echo "*.log" > .gitignore

git checkout 82b51ba267a0d23ba1a969ca2a0061d496b0acae
git switch -
git revert 82b51ba267a0d23ba1a969ca2a0061d496b0acae
git reset --hard 82b51ba267a0d23ba1a969ca2a0061d496b0acae

git branch -a
git branch feature
git switch feature
git merge --squash feature
git branch -d feature

git remote -v
git remote add origin https://github.com/edmond-chow/experimental.git
git clone origin
git push -f origin master
git pull origin master
git rebase master
