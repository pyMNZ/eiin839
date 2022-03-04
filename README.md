# EIIN839 - ECUE Service oriented computing/WS
# Author - Pierre-Yves Munoz

## Pour le TD2

Les questions 1 et 2 sont trouvables dans le projet **BasicWebServerUrlParser** (dossier BasicWebServer). Il suffit de lancer ce projet et d'aller sur les URLS (qui sont écrites dans MyMehods.cs) suivantes:
 - Question 1: http://localhost:8080/Method1?param1=test&param2=test2 et http://localhost:8080/Method2?param1=test&param2=test2
 - Question 2: http://localhost:8080/MethodExternal?param1=test&param2=test2

Pour la question 3, définir plusieurs projets de démarages: Q3 et ClientQ3 (**ATTENTION: Ne PAS mettre "exécuter sans débogage"**). 
Vérifier que ClientQ3 est **dépendant** de Q3.
Éxécuter, le ClientQ3 appel Q3 avec l'URL: http://localhost:8080/Incr?param1=5
