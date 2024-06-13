# TrackItAll API

TrackItAll API is a .NET-based API for inventory management and tracking. This guide will help you set up the necessary environment, configure the database, and run the server for development purposes.

## Prerequisites

1. **.NET SDK**: Ensure you have the .NET SDK installed. You can download it from [here](https://dotnet.microsoft.com/download).

2. **PostgreSQL**: Install PostgreSQL version 16.3. Follow the installation instructions for your operating system [here](https://www.postgresql.org/download/).

## Setting Up PostgreSQL

1. **Start PostgreSQL Service**:
    - On Linux:
        ```sh
        sudo service postgresql start
        ```
	- On Windows:
		```sh
		pg_ctl.exe restart -D "<path upto data>"
		```

2. **Open PostgreSQL Console**:
    - On Linux:
        ```sh
        sudo -u postgres psql
        ```

3. **Create PostgreSQL User**:
    In the PostgreSQL console, execute the following command to create a user:
    ```sql
    CREATE ROLE userName WITH SUPERUSER LOGIN PASSWORD 'userPassword';
    ```

## Setting Up the Database

2. **Add the Environment Variables**:
    In your project directory, copy the `env.template` file and rename it to `.env` and change the variables

		```sh
		DB_USERNAME=YOUR_POSTGRE_USERNAME
		DB_PASSWORD=YOUR_POSTGRE_PASSWORD
		```


2. **Run .NET Migrations**:
    In your project directory, run the following command to apply the migrations and create the `track-it-all` database:
    ```sh
    dotnet ef database update
    ```

    > **Note**: If `dotnet ef` is not working, ensure that the .NET CLI tools are included in your PATH.

## Running the Development Server

You can run the development server in two modes:

1. **Hot Reload Dev Server**:
    ```sh
    dotnet watch
    ```

2. **Normal Dev Server**:
    ```sh
    dotnet run
    ```

## Accessing the API

Once the server is running, navigate to [http://localhost:5066/graphql/](http://localhost:5066/graphql/) in your browser to start making requests.

Happy tracking!

---

Feel free to contribute to the project or report any issues. For more information, check out the project documentation or contact the maintainers.
