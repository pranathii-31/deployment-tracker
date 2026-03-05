# Deployment Dashboard

A full-stack deployment tracking dashboard built using Angular and ASP.NET Core.

The application allows teams to record, monitor, and manage deployment history across environments.

## Tech Stack

Frontend:
- Angular
- TypeScript
- CSS

Backend:
- ASP.NET Core Web API
- Entity Framework Core
- SQLite

DevOps (planned):
- GitHub Actions
- CI/CD Pipeline
- IIS Deployment on Windows VM

## Features

- Add deployment records
- View deployment history
- Delete deployments
- Status badges (success / fail)
- SQLite persistence

## Project Structure

deployment-tracker
│
├── frontend
│   └── deployment-dashboard
│
├── backend
│   └── DeploymentTrackerAPI
│
└── .github/workflows (CI/CD pipelines)

## Running Locally

### Backend
