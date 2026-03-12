import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class DeploymentService {

  private apiUrl = 'http://localhost:5130/api/deployments';

  constructor(private http: HttpClient) {}

  getDeployments() {
    return this.http.get<any[]>(this.apiUrl);
  }

  addDeployment(data: any) {
    return this.http.post(this.apiUrl, data);
  }

  deleteDeployment(id: number) {
    return this.http.delete(`${this.apiUrl}/${id}`);
  }

}