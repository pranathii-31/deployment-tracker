import { Component, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { DeploymentService } from './services/deployment';
import { HttpClientModule } from '@angular/common/http';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [CommonModule, FormsModule, HttpClientModule],
  templateUrl: './app.html',
  styleUrl: './app.css'
})
export class AppComponent implements OnInit {

  deployments: any[] = [];

  newDeployment = {
    appName: '',
    version: '',
    environment: '',
    status: ''
  };

  constructor(private deploymentService: DeploymentService) { }

  ngOnInit() {
    this.loadDeployments();
  }

  loadDeployments() {
    this.deploymentService.getDeployments()
      .subscribe(data => {
        this.deployments = data;
      });
  }

  addDeployment() {

    this.deploymentService.addDeployment(this.newDeployment)
      .subscribe(() => {

        this.loadDeployments();

        this.newDeployment = {
          appName: '',
          version: '',
          environment: '',
          status: ''
        };

      });
  }

  deleteDeployment(id: number) {

    if (confirm("Are you sure you want to delete this deployment?")) {

      this.deploymentService.deleteDeployment(id)
        .subscribe(() => {
          this.loadDeployments();
        });

    }

  }

}