all:
	@echo "Missing parameter!"

migration:
	@dotnet ef migrations add --project WebApp/ $(name)

list:
	@dotnet ef migrations list --project WebApp/

update:
	@dotnet ef database update --project WebApp/

drop:
	@dotnet ef database drop --project WebApp/

clean:
	@rm -r WebApp/DbHandler/Migrations/
