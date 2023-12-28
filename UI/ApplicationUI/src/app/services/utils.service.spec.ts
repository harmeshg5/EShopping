import { ComponentFixture, TestBed } from "@angular/core/testing";
import { UtilsService } from "./utils.service"

describe('service testing', () => {
    let utilsService: UtilsService;

    beforeEach(() => {
        TestBed.configureTestingModule({
            providers: [UtilsService],
        }).compileComponents();

        utilsService = TestBed.inject(UtilsService);


    });

    it('create service', () => {
        expect(utilsService).toBeTruthy();
    });

    describe('range', () => {

        it('returns correct result for 1-6 range', () => {
            const result = utilsService.range(1, 6);
            const expected = [1, 2, 3, 4, 5];
            expect(result).toEqual(expected);
        })
    })
})