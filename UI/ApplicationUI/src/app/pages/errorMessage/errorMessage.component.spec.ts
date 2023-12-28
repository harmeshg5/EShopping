import { ComponentFixture, TestBed } from "@angular/core/testing";
import { ErrorMessageComponent } from "./errorMessage.component"
import { By } from "@angular/platform-browser";


describe('ErrorMessageComponent Testing', () => {
    let component: ErrorMessageComponent;
    let fixture: ComponentFixture<ErrorMessageComponent>;

    beforeEach(() => {
        TestBed.configureTestingModule({
            imports: [ErrorMessageComponent],
        }).compileComponents();

        fixture = TestBed.createComponent(ErrorMessageComponent);
        component = fixture.componentInstance;
        fixture.detectChanges();
    });

    it('create component', () => {
        expect(component).toBeTruthy();
    });

    it('render default error msg', () => {
        const msgContainer = fixture.debugElement.query(By.css('[data-testId="message-container"]'));

        expect(msgContainer.nativeElement.textContent).toBe('Something went wrong!');
    });
    
});