import { Component, EventEmitter, Input, OnInit, Output } from "@angular/core";
import { UtilsService } from "../../services/utils.service";
import { CommonModule } from "@angular/common";


@Component({
    selector: 'app-pagination',
    templateUrl: './pagination.component.html',
    standalone: true,
    imports: [CommonModule]
})
export class PaginationComponent implements OnInit {

    @Input() total: number = 0;
    @Input() limit: number = 20;
    @Input() currentPage: number = 1;

    pageCount: number = 10;
    pages: number[] = [];

    @Output('pageChange') pageChangeEvent = new EventEmitter<number>();

    constructor(private utilsService: UtilsService) { }

    ngOnInit(): void {
        this.pageCount = Math.ceil(this.total / this.limit);
        this.pages = this.pageCount > 0 ? this.utilsService.range(1, this.pageCount + 1) : [];
    }

    selectPage(page: number): void {
        this.pageChangeEvent.emit(page);
    }



}