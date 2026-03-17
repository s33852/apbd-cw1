"# apbd-cw1" 
new line ^^

1. When does Git perform a fast-forward and when is a merge commit created? 

Git does a fast-forward merge when the parent branch hasn’t changed while you were working on the child branch. A merge commit is created when Git needs to combine changes from both branches.

2. What is the practical difference between merge and rebase? 

A merge adds new changes to the parent branch, but a rebase rewrites history and can remove changes on the parent branch if you’re not careful.

3. How was the conflict resolved in your repository? 

I fixed the conflict by choosing the file with the correct method