# Introduction 
Hierbij een korte instructie over het correct aanmaken van branches en deze weer mergen op de main branch.



# Getting Started
Bij het maken van een nieuwe taak ga je af branchen van de main branch dit doe met het volgende commando

```
git checkout -b <branch name> 
```



Check met het volgende commando op welke branch je zit

```
git branch
```



Je nieuwe code committen werkt hetzelfde alleen bij het pushen vanaf een nieuwe local branch moet er wat meer gebeuren om de branch ook op de remote te krijgen **let goed op dat je de goeie branch name gebruikt**

```
git add .
git commit -m "Commit message"
git push --set-upstream origin <branch name> 
```



Als je taak klaar is kan je de nieuwe code mergen naar de main branch voor dat je dit kan doen moet je eerst je branch up-to-date maken met de main branch dit doe je door naar de branch te gaan waar je de taak op hebt gemaakt en het en het mergen met de main branch. De commando's zijn als volgt.

```
git checkout <branch name>
git merge main
```



Nu is de branch up-to-date met de main branch en kan het gemerged worden met de main branch. **Om merge conflicts te voorkomen maken we gebruik van pull request,** dit doe je via de devops repo via daar kan je een pull request aanmaken en kijken of er geen merge conflicts zijn. Zijn deze er niet dan kan je de pull request approven en completen.
