import { NgModule, CommonModule, RouterModule } from "../shared/utilities/angular";
import { DataService } from "./services/global/data.service";

@NgModule({
    imports: [
        CommonModule,
        RouterModule
    ],
    providers: [
        DataService
    ],
    exports: [
        CommonModule
    ]
})

export class SharedModule {

    constructor() {

    }
}