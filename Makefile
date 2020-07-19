all:
	@echo "Missing parameter!"

migration:
	@dotnet ef migrations add --startup-project WebApp/ --project DatabaseHandler/ $(name)

list:
	@dotnet ef migrations list --startup-project WebApp/ --project DatabaseHandler

update:
	@dotnet ef database update --startup-project WebApp/ --project DatabaseHandler/

drop:
	@dotnet ef database drop --startup-project WebApp/ --project DatabaseHandler/

clean:
	@rm -r DatabaseHandler/Migrations/

