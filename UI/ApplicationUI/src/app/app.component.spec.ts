import { ComponentFixture, TestBed } from "@angular/core/testing";
import { AppComponent } from "./app.component";


describe('App Component Testing', () => {
    let component: AppComponent;
    let fixture: ComponentFixture<AppComponent>;

    beforeEach(async () => {
        await TestBed.configureTestingModule({
            imports: [AppComponent],

        }).compileComponents();

        fixture = TestBed.createComponent(AppComponent);
        component = fixture.componentInstance;
        fixture.detectChanges();
    });

    it('should be create', ()=>{
        expect(component).toBeTruthy();
    })

});