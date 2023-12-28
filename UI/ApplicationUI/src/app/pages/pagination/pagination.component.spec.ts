import { ComponentFixture, TestBed } from "@angular/core/testing";
import { PaginationComponent } from "./pagination.component"
import { By } from "@angular/platform-browser";
import { first } from "rxjs";
import { UtilsService } from "../../services/utils.service";

describe('pagination component test', () => {
    let component: PaginationComponent;
    let fixture: ComponentFixture<PaginationComponent>;
    const mockUtilService = {
        range: () => [1, 2, 3, 4, 5]
    };

    beforeEach(() => {
        TestBed.configureTestingModule({
            imports: [PaginationComponent],
            providers: [{ provide: UtilsService, useValue: mockUtilService }]

        }).compileComponents();

        fixture = TestBed.createComponent(PaginationComponent);
        component = fixture.componentInstance;
        component.total = 50;
        component.limit = 10;
        component.currentPage = 1;
        fixture.detectChanges();
    });

    it('Test a component', () => {
        expect(component).toBeTruthy();
    });

    it('renders correct pagination-', () => {
        const pageContainer = fixture.debugElement.queryAll(By.css('[data-testId="page-container"]'));

        expect(pageContainer.length).toBe(5);
        expect(pageContainer.at(0)?.nativeElement.textContent).toEqual(' 1 ');
    });

    it('should emit a clicked page', () => {
        const pageContainer = fixture.debugElement.queryAll(By.css('[data-testId="page-container"]'));

        let clickedPage: number | undefined;

        component.pageChangeEvent.pipe(first()).subscribe((page) => {
            clickedPage = page;
        });

        pageContainer.at(0)?.triggerEventHandler('click');

        expect(clickedPage).toEqual(1);
    });

})