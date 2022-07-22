set br=FME-29091_platform_data_transaction_history_implementation
set cm=FME-29091 Platform data transaction history implementation

git checkout dev_inschool
git pull

git branch %br%
git checkout %br%
git pull

git add .
git commit -m "%cm%"
git push --set-upstream origin %br% 

FOR /F "delims=" %i in (\work\ip.txt) do @echo %i

FOR /F "usebackq delims==" %i IN (`dir /b /ad`) DO (
)

FOR /F "delims=" %i in (\work\ip.txt) do (

FOR /F "usebackq delims==" %i IN (`dir /b /ad`) DO (
cd %i
git checkout dev_inschool
git pull
cd ..
) 

git branch FME-27741_secret_to_env_variable_changes
git checkout FME-27741_secret_to_env_variable_changes


FOR /F "usebackq delims==" %i IN (`dir /b /ad`) DO (
cd %i
git status 
cd ..
)
