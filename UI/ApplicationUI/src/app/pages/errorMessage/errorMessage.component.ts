import { Component, Input } from "@angular/core";


@Component({
    selector: 'app-errormessage',
    templateUrl: './errorMessage.component.html',
    standalone: true,
    imports: []
})
export class ErrorMessageComponent {

    @Input() message: string = "Something went wrong!";
}